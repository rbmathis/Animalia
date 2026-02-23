using AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Urocolius;

/// <summary>
/// Abstract class for Urocolius (genus).
/// NCBI TaxId: 85100
/// </summary>
public abstract class Urocolius : Coliidae, IUrocolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urocolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85100;

    /// <inheritdoc />
    public virtual string GenusName => "Urocolius";

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
