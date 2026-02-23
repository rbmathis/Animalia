using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Willisornis;

/// <summary>
/// Abstract class for Willisornis (genus).
/// NCBI TaxId: 870536
/// </summary>
public abstract class Willisornis : Thamnophilidae, IWillisornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Willisornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 870536;

    /// <inheritdoc />
    public virtual string GenusName => "Willisornis";

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
