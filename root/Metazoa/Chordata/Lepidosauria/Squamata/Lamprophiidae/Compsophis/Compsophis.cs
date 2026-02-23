using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Compsophis;

/// <summary>
/// Abstract class for Compsophis (genus).
/// NCBI TaxId: 224541
/// </summary>
public abstract class Compsophis : Lamprophiidae, ICompsophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Compsophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224541;

    /// <inheritdoc />
    public virtual string GenusName => "Compsophis";

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
