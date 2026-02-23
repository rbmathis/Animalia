using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Microbates;

/// <summary>
/// Abstract class for Microbates (genus).
/// NCBI TaxId: 700773
/// </summary>
public abstract class Microbates : Certhiidae, IMicrobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microbates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700773;

    /// <inheritdoc />
    public virtual string GenusName => "Microbates";

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
