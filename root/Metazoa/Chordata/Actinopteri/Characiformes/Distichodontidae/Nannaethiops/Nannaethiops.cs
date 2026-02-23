using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Nannaethiops;

/// <summary>
/// Abstract class for Nannaethiops (genus).
/// NCBI TaxId: 1381075
/// </summary>
public abstract class Nannaethiops : Distichodontidae, INannaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1381075;

    /// <inheritdoc />
    public virtual string GenusName => "Nannaethiops";

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
