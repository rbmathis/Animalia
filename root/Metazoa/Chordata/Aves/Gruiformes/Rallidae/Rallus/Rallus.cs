using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallus;

/// <summary>
/// Abstract class for Rallus (genus).
/// NCBI TaxId: 54360
/// </summary>
public abstract class Rallus : Rallidae, IRallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54360;

    /// <inheritdoc />
    public virtual string GenusName => "Rallus";

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
