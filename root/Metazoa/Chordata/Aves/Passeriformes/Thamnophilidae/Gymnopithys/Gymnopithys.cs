using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Gymnopithys;

/// <summary>
/// Abstract class for Gymnopithys (genus).
/// NCBI TaxId: 288081
/// </summary>
public abstract class Gymnopithys : Thamnophilidae, IGymnopithys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnopithys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288081;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnopithys";

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
