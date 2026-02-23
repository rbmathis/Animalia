using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ectopistes;

/// <summary>
/// Abstract class for Ectopistes (genus).
/// NCBI TaxId: 187117
/// </summary>
public abstract class Ectopistes : Columbidae, IEctopistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ectopistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187117;

    /// <inheritdoc />
    public virtual string GenusName => "Ectopistes";

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
