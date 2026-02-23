using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Stephanoberycidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Stephanoberycidae.Acanthochaenus;

/// <summary>
/// Abstract class for Acanthochaenus (genus).
/// NCBI TaxId: 473343
/// </summary>
public abstract class Acanthochaenus : Stephanoberycidae, IAcanthochaenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthochaenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473343;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthochaenus";

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
