using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Neosynchiropus;

/// <summary>
/// Abstract class for Neosynchiropus (genus).
/// NCBI TaxId: 1147759
/// </summary>
public abstract class Neosynchiropus : Callionymidae, INeosynchiropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neosynchiropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1147759;

    /// <inheritdoc />
    public virtual string GenusName => "Neosynchiropus";

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
