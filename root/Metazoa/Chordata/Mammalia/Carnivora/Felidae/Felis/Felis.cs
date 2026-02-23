using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felis;

/// <summary>
/// Abstract class for Felis (genus).
/// NCBI TaxId: 9682
/// </summary>
public abstract class Felis : Felidae, IFelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Felis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9682;

    /// <inheritdoc />
    public virtual string GenusName => "Felis";

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
