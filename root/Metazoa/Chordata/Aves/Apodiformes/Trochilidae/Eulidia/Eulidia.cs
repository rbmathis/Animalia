using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Eulidia;

/// <summary>
/// Abstract class for Eulidia (genus).
/// NCBI TaxId: 1159641
/// </summary>
public abstract class Eulidia : Trochilidae, IEulidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1159641;

    /// <inheritdoc />
    public virtual string GenusName => "Eulidia";

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
