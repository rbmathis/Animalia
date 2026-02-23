using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lugubria;

/// <summary>
/// Abstract class for Lugubria (genus).
/// NCBI TaxId: 3102744
/// </summary>
public abstract class Lugubria : Cichlidae, ILugubria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lugubria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3102744;

    /// <inheritdoc />
    public virtual string GenusName => "Lugubria";

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
