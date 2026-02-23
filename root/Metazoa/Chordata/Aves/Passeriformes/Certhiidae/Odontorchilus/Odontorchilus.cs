using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Odontorchilus;

/// <summary>
/// Abstract class for Odontorchilus (genus).
/// NCBI TaxId: 241546
/// </summary>
public abstract class Odontorchilus : Certhiidae, IOdontorchilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontorchilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241546;

    /// <inheritdoc />
    public virtual string GenusName => "Odontorchilus";

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
