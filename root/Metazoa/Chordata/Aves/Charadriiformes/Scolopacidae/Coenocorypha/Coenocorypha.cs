using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Coenocorypha;

/// <summary>
/// Abstract class for Coenocorypha (genus).
/// NCBI TaxId: 425630
/// </summary>
public abstract class Coenocorypha : Scolopacidae, ICoenocorypha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coenocorypha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425630;

    /// <inheritdoc />
    public virtual string GenusName => "Coenocorypha";

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
