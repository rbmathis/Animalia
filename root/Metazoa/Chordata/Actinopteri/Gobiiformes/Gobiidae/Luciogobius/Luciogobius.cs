using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Luciogobius;

/// <summary>
/// Abstract class for Luciogobius (genus).
/// NCBI TaxId: 228540
/// </summary>
public abstract class Luciogobius : Gobiidae, ILuciogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luciogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228540;

    /// <inheritdoc />
    public virtual string GenusName => "Luciogobius";

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
