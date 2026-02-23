using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Askoldia;

/// <summary>
/// Abstract class for Askoldia (genus).
/// NCBI TaxId: 986103
/// </summary>
public abstract class Askoldia : Stichaeidae, IAskoldia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Askoldia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 986103;

    /// <inheritdoc />
    public virtual string GenusName => "Askoldia";

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
