using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Scolecenchelys;

/// <summary>
/// Abstract class for Scolecenchelys (genus).
/// NCBI TaxId: 391187
/// </summary>
public abstract class Scolecenchelys : Ophichthidae, IScolecenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scolecenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391187;

    /// <inheritdoc />
    public virtual string GenusName => "Scolecenchelys";

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
