using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Amblyodipsas;

/// <summary>
/// Abstract class for Amblyodipsas (genus).
/// NCBI TaxId: 292857
/// </summary>
public abstract class Amblyodipsas : Lamprophiidae, IAmblyodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292857;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyodipsas";

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
