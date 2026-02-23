using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Petroicidae.Petroica;

/// <summary>
/// Abstract class for Petroica (genus).
/// NCBI TaxId: 228563
/// </summary>
public abstract class Petroica : Petroicidae, IPetroica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petroica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228563;

    /// <inheritdoc />
    public virtual string GenusName => "Petroica";

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
