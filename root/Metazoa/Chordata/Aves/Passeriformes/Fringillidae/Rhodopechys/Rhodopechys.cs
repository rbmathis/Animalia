using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Rhodopechys;

/// <summary>
/// Abstract class for Rhodopechys (genus).
/// NCBI TaxId: 163858
/// </summary>
public abstract class Rhodopechys : Fringillidae, IRhodopechys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodopechys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163858;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodopechys";

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
