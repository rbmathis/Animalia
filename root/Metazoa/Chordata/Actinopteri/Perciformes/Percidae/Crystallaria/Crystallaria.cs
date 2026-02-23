using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Crystallaria;

/// <summary>
/// Abstract class for Crystallaria (genus).
/// NCBI TaxId: 54324
/// </summary>
public abstract class Crystallaria : Percidae, ICrystallaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crystallaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54324;

    /// <inheritdoc />
    public virtual string GenusName => "Crystallaria";

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
