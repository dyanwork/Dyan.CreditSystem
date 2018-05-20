import { OceanAngularTemplatePage } from './app.po';

describe('OceanAngular App', function() {
  let page: OceanAngularTemplatePage;

  beforeEach(() => {
    page = new OceanAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
