using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Galbulidae.Galbula;

/// <summary>
/// Abstract class for Galbula (genus).
/// NCBI TaxId: 118186
/// </summary>
public abstract class Galbula : Galbulidae, IGalbula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galbula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118186;

    /// <inheritdoc />
    public virtual string GenusName => "Galbula";

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
