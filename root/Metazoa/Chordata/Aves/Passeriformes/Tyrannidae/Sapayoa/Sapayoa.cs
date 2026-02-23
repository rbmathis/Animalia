using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sapayoa;

/// <summary>
/// Abstract class for Sapayoa (genus).
/// NCBI TaxId: 239369
/// </summary>
public abstract class Sapayoa : Tyrannidae, ISapayoa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sapayoa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 239369;

    /// <inheritdoc />
    public virtual string GenusName => "Sapayoa";

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
