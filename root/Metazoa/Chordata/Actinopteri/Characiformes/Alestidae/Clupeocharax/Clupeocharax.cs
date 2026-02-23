using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Clupeocharax;

/// <summary>
/// Abstract class for Clupeocharax (genus).
/// NCBI TaxId: 1042451
/// </summary>
public abstract class Clupeocharax : Alestidae, IClupeocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupeocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1042451;

    /// <inheritdoc />
    public virtual string GenusName => "Clupeocharax";

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
