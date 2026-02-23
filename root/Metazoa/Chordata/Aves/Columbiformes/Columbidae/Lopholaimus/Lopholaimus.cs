using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Lopholaimus;

/// <summary>
/// Abstract class for Lopholaimus (genus).
/// NCBI TaxId: 444143
/// </summary>
public abstract class Lopholaimus : Columbidae, ILopholaimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lopholaimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 444143;

    /// <inheritdoc />
    public virtual string GenusName => "Lopholaimus";

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
