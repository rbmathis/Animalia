using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Cercomacroides;

/// <summary>
/// Abstract class for Cercomacroides (genus).
/// NCBI TaxId: 2767395
/// </summary>
public abstract class Cercomacroides : Thamnophilidae, ICercomacroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cercomacroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2767395;

    /// <inheritdoc />
    public virtual string GenusName => "Cercomacroides";

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
