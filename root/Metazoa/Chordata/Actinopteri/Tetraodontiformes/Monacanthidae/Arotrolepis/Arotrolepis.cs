using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Arotrolepis;

/// <summary>
/// Abstract class for Arotrolepis (genus).
/// NCBI TaxId: 3362415
/// </summary>
public abstract class Arotrolepis : Monacanthidae, IArotrolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arotrolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362415;

    /// <inheritdoc />
    public virtual string GenusName => "Arotrolepis";

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
