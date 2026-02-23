using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Callechelys;

/// <summary>
/// Abstract class for Callechelys (genus).
/// NCBI TaxId: 1156453
/// </summary>
public abstract class Callechelys : Ophichthidae, ICallechelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callechelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156453;

    /// <inheritdoc />
    public virtual string GenusName => "Callechelys";

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
