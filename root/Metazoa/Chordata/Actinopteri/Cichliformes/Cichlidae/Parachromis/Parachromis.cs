using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Parachromis;

/// <summary>
/// Abstract class for Parachromis (genus).
/// NCBI TaxId: 63176
/// </summary>
public abstract class Parachromis : Cichlidae, IParachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63176;

    /// <inheritdoc />
    public virtual string GenusName => "Parachromis";

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
