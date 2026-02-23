using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Abroscopus;

/// <summary>
/// Abstract class for Abroscopus (genus).
/// NCBI TaxId: 330770
/// </summary>
public abstract class Abroscopus : Sylviidae, IAbroscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abroscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330770;

    /// <inheritdoc />
    public virtual string GenusName => "Abroscopus";

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
