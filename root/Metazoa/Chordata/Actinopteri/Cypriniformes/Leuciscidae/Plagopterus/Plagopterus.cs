using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Plagopterus;

/// <summary>
/// Abstract class for Plagopterus (genus).
/// NCBI TaxId: 181615
/// </summary>
public abstract class Plagopterus : Leuciscidae, IPlagopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plagopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181615;

    /// <inheritdoc />
    public virtual string GenusName => "Plagopterus";

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
