using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callimico;

/// <summary>
/// Abstract class for Callimico (genus).
/// NCBI TaxId: 9494
/// </summary>
public abstract class Callimico : Cebidae, ICallimico
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callimico";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9494;

    /// <inheritdoc />
    public virtual string GenusName => "Callimico";

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
