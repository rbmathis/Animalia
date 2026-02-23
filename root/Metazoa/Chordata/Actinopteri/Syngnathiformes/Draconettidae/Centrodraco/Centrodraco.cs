using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae.Centrodraco;

/// <summary>
/// Abstract class for Centrodraco (genus).
/// NCBI TaxId: 1696907
/// </summary>
public abstract class Centrodraco : Draconettidae, ICentrodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696907;

    /// <inheritdoc />
    public virtual string GenusName => "Centrodraco";

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
