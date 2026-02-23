using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Alticorpus;

/// <summary>
/// Abstract class for Alticorpus (genus).
/// NCBI TaxId: 163611
/// </summary>
public abstract class Alticorpus : Cichlidae, IAlticorpus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alticorpus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163611;

    /// <inheritdoc />
    public virtual string GenusName => "Alticorpus";

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
