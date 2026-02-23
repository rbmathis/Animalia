using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Catherpes;

/// <summary>
/// Abstract class for Catherpes (genus).
/// NCBI TaxId: 241528
/// </summary>
public abstract class Catherpes : Certhiidae, ICatherpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catherpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241528;

    /// <inheritdoc />
    public virtual string GenusName => "Catherpes";

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
