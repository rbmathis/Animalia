using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Pholidichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Pholidichthyidae.Pholidichthys;

/// <summary>
/// Abstract class for Pholidichthys (genus).
/// NCBI TaxId: 390367
/// </summary>
public abstract class Pholidichthys : Pholidichthyidae, IPholidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pholidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390367;

    /// <inheritdoc />
    public virtual string GenusName => "Pholidichthys";

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
