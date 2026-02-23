using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Alcedinidae.Ispidina;

/// <summary>
/// Abstract class for Ispidina (genus).
/// NCBI TaxId: 2577022
/// </summary>
public abstract class Ispidina : Alcedinidae, IIspidina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ispidina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2577022;

    /// <inheritdoc />
    public virtual string GenusName => "Ispidina";

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
