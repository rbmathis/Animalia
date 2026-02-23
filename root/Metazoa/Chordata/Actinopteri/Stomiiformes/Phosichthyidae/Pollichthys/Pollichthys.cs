using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Pollichthys;

/// <summary>
/// Abstract class for Pollichthys (genus).
/// NCBI TaxId: 882880
/// </summary>
public abstract class Pollichthys : Phosichthyidae, IPollichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pollichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882880;

    /// <inheritdoc />
    public virtual string GenusName => "Pollichthys";

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
