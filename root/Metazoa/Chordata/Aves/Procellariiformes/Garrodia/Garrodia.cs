using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Garrodia;

/// <summary>
/// Abstract class for Garrodia (genus).
/// NCBI TaxId: 79648
/// </summary>
public abstract class Garrodia : Procellariiformes, IGarrodia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garrodia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 79648;

    /// <inheritdoc />
    public virtual string GenusName => "Garrodia";

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
