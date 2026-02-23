using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pelecus;

/// <summary>
/// Abstract class for Pelecus (genus).
/// NCBI TaxId: 317924
/// </summary>
public abstract class Pelecus : Leuciscidae, IPelecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317924;

    /// <inheritdoc />
    public virtual string GenusName => "Pelecus";

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
