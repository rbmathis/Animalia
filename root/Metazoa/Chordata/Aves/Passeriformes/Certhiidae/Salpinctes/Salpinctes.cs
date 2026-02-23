using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Salpinctes;

/// <summary>
/// Abstract class for Salpinctes (genus).
/// NCBI TaxId: 241548
/// </summary>
public abstract class Salpinctes : Certhiidae, ISalpinctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salpinctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241548;

    /// <inheritdoc />
    public virtual string GenusName => "Salpinctes";

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
