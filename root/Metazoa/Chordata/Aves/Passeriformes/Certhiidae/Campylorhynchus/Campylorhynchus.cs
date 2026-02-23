using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Campylorhynchus;

/// <summary>
/// Abstract class for Campylorhynchus (genus).
/// NCBI TaxId: 69502
/// </summary>
public abstract class Campylorhynchus : Certhiidae, ICampylorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campylorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69502;

    /// <inheritdoc />
    public virtual string GenusName => "Campylorhynchus";

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
