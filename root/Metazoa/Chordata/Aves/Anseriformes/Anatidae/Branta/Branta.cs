using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Branta;

/// <summary>
/// Abstract class for Branta (genus).
/// NCBI TaxId: 8852
/// </summary>
public abstract class Branta : Anatidae, IBranta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Branta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8852;

    /// <inheritdoc />
    public virtual string GenusName => "Branta";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
