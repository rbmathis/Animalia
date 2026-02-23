using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Atlantisia;

/// <summary>
/// Abstract class for Atlantisia (genus).
/// NCBI TaxId: 2478891
/// </summary>
public abstract class Atlantisia : Rallidae, IAtlantisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atlantisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2478891;

    /// <inheritdoc />
    public virtual string GenusName => "Atlantisia";

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
