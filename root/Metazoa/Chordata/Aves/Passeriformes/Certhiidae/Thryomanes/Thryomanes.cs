using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Thryomanes;

/// <summary>
/// Abstract class for Thryomanes (genus).
/// NCBI TaxId: 241535
/// </summary>
public abstract class Thryomanes : Certhiidae, IThryomanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thryomanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241535;

    /// <inheritdoc />
    public virtual string GenusName => "Thryomanes";

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
