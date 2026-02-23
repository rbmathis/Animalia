using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Pholidapus;

/// <summary>
/// Abstract class for Pholidapus (genus).
/// NCBI TaxId: 470927
/// </summary>
public abstract class Pholidapus : Stichaeidae, IPholidapus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholidapus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 470927;

    /// <inheritdoc />
    public virtual string GenusName => "Pholidapus";

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
