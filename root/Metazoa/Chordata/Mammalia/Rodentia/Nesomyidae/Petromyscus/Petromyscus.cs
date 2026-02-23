using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Petromyscus;

/// <summary>
/// Abstract class for Petromyscus (genus).
/// NCBI TaxId: 107278
/// </summary>
public abstract class Petromyscus : Nesomyidae, IPetromyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petromyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107278;

    /// <inheritdoc />
    public virtual string GenusName => "Petromyscus";

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
