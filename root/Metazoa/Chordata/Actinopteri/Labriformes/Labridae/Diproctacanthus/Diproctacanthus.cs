using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Diproctacanthus;

/// <summary>
/// Abstract class for Diproctacanthus (genus).
/// NCBI TaxId: 241286
/// </summary>
public abstract class Diproctacanthus : Labridae, IDiproctacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diproctacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241286;

    /// <inheritdoc />
    public virtual string GenusName => "Diproctacanthus";

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
