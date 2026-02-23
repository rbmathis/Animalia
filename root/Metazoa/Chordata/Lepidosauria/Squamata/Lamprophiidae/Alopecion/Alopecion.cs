using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Alopecion;

/// <summary>
/// Abstract class for Alopecion (genus).
/// NCBI TaxId: 3148921
/// </summary>
public abstract class Alopecion : Lamprophiidae, IAlopecion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alopecion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148921;

    /// <inheritdoc />
    public virtual string GenusName => "Alopecion";

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
