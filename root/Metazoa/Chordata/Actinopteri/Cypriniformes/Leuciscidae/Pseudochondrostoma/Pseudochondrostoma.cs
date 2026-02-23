using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudochondrostoma;

/// <summary>
/// Abstract class for Pseudochondrostoma (genus).
/// NCBI TaxId: 437167
/// </summary>
public abstract class Pseudochondrostoma : Leuciscidae, IPseudochondrostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudochondrostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 437167;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudochondrostoma";

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
