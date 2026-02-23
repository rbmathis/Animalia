using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Cabalus;

/// <summary>
/// Abstract class for Cabalus (genus).
/// NCBI TaxId: 2861789
/// </summary>
public abstract class Cabalus : Rallidae, ICabalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cabalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861789;

    /// <inheritdoc />
    public virtual string GenusName => "Cabalus";

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
