using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Hartertula;

/// <summary>
/// Abstract class for Hartertula (genus).
/// NCBI TaxId: 552917
/// </summary>
public abstract class Hartertula : Bernieridae, IHartertula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hartertula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 552917;

    /// <inheritdoc />
    public virtual string GenusName => "Hartertula";

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
