using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Tephrinectes;

/// <summary>
/// Abstract class for Tephrinectes (genus).
/// NCBI TaxId: 367199
/// </summary>
public abstract class Tephrinectes : Paralichthyidae, ITephrinectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tephrinectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 367199;

    /// <inheritdoc />
    public virtual string GenusName => "Tephrinectes";

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
