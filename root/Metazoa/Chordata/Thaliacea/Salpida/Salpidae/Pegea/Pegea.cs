using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Pegea;

/// <summary>
/// Abstract class for Pegea (genus).
/// NCBI TaxId: 942561
/// </summary>
public abstract class Pegea : Salpidae, IPegea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pegea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 942561;

    /// <inheritdoc />
    public virtual string GenusName => "Pegea";

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
