using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Chaenocephalus;

/// <summary>
/// Abstract class for Chaenocephalus (genus).
/// NCBI TaxId: 36189
/// </summary>
public abstract class Chaenocephalus : Channichthyidae, IChaenocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36189;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenocephalus";

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
