using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Lagothrix;

/// <summary>
/// Abstract class for Lagothrix (genus).
/// NCBI TaxId: 9518
/// </summary>
public abstract class Lagothrix : Atelidae, ILagothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9518;

    /// <inheritdoc />
    public virtual string GenusName => "Lagothrix";

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
