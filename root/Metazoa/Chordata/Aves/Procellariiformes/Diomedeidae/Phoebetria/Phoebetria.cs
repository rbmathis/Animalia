using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Phoebetria;

/// <summary>
/// Abstract class for Phoebetria (genus).
/// NCBI TaxId: 46543
/// </summary>
public abstract class Phoebetria : Diomedeidae, IPhoebetria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoebetria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46543;

    /// <inheritdoc />
    public virtual string GenusName => "Phoebetria";

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
