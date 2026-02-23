using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Diomedea;

/// <summary>
/// Abstract class for Diomedea (genus).
/// NCBI TaxId: 37068
/// </summary>
public abstract class Diomedea : Diomedeidae, IDiomedea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diomedea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37068;

    /// <inheritdoc />
    public virtual string GenusName => "Diomedea";

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
