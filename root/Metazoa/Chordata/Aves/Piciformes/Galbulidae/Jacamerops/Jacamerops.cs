using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae.Jacamerops;

/// <summary>
/// Abstract class for Jacamerops (genus).
/// NCBI TaxId: 1109060
/// </summary>
public abstract class Jacamerops : Galbulidae, IJacamerops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jacamerops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109060;

    /// <inheritdoc />
    public virtual string GenusName => "Jacamerops";

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
